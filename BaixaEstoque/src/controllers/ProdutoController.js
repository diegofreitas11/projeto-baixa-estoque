const Produto = require('../models/Produto');



module.exports = {
    async index(req, res){
        const produtos = await Produto.findAll();
        console.log(produtos)
        return res.json(produtos);    
    },

    async show(req, res){
        const produto = await Produto.findByPk(req.params.id)
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