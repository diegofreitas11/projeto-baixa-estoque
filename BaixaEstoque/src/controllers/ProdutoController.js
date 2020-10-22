const Produto = require('../models/Produto');
const Transacao = require('../models/Transacao');

module.exports = {
    async index(req, res){
        const produtos = await Produto.findAll();
        console.log(produtos)
        return res.json(produtos);    
    },

    async indexWithTransactions(req, res){ //traz os produtos com as transações
        const produtos = await Produto.findAll({
            include: {
                model: Transacao,
                as: 'transacoes',
                required: true
            }
        })

        return res.json(produtos);
    },

    async indexWithTransactionsByType(req, res){
        const produtos = await Produto.findAll({
            include:{
                model: Transacao,
                as: 'transacoes',
                where: {
                    tipo: req.params.tipo
                },
                required: true
            }
        })

        return res.json(produtos);
    },

    async show(req, res){
        const produto = await Produto.findByPk(req.params.id)
        return res.json(produto);
    },

    async showWithTransactions(req, res){
        const produto = await Produto.findByPk(req.params.id,{
            include: {
                model: Transacao,
                as: 'transacoes',
                required: true
            }
        })
        return res.json(produto);
    },

    async store(req, res){
        await Produto.create(req.body);
        return res.json('ok');
    },

    async update(req, res){
        await Produto.update(req.body, 
            {where: {id: req.params.id}}
        );
        return res.json('ok');
    },
    
    async destroy(req, res){
        await Produto.destroy({
            where: {id: req.params.id}
        });
        return res.json('ok');
    }

    
};