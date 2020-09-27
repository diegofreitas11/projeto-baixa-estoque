const Transacao = require('../models/Transacao');
const Produto = require('../models/Produto');


module.exports = {
    async index(req, res){
        const transacoes = await Transacao.findAll();
        return res.json(transacoes);
    },

    async store(req, res){
        await Transacao.create(req.body);
        return res.json('ok');
    }
}