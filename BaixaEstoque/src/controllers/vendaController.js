const connection = require('../dbConnection')
const cmodel = require('../models/compraModel');
const compraModel = new cmodel();
const vmodel = require('../models/vendaModel');
const vendaModel = new vmodel();

class VendaController{
    constructor(){
        this.getTransacoes = function(callback){
            vendaModel.getAll(connection, callback);
        };

        this.addTransacao = function(req, callback){
            let venda = req.body;
            let produtos = JSON.parse(req.body.produtos_baixa);
            console.log(produtos);
              
            produtos.forEach(item => {
                delete item.nome;
                console.log(item);
                compraModel.updade(item, connection, item.id);
            });
            
            delete venda.produtos_baixa;
            delete venda.metodo;
            vendaModel.insert(venda, connection, callback);
        };

        this.getTransacao = function(id, callback){
            vendaModel.getById(connection, id, callback);
        }

        this.updateTransacao = function(req, id, callback){    
            let compra = req.body;
            vendaModel.updade(compra, connection, id, callback)
        }

    }

}

module.exports = VendaController