const connection = require('../dbConnection');
const cmodel = require('../models/compraModel');
const compraModel = new cmodel();


class CompraController{
    constructor(){
        this.getTransacoes = function(callback){
            compraModel.getAll(connection, callback);
        };

        this.addTransacao = function(req, callback){
            let compra = req.body;
            compraModel.insert(compra, connection, callback);
        };

        this.getTransacao= function(id, callback){
            compraModel.getById(connection, id, callback);
        }

        this.updateTransacao = function(req, id, callback){    
            let compra = req.body;
            compraModel.updade(compra, connection, id, callback)
        }

    }

}

module.exports = CompraController