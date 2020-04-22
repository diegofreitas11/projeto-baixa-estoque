const connection = require('../dbConnection')
const model = require('../models/produtoModel');
const produtoModel = new model();


class ProdutoController{
    constructor(){
        this.getProdutos = function(callback){
            produtoModel.getAll(connection, callback);
        };

        this.getProdutosComValor = function(callback){
            produtoModel.join(connection, callback);
        }

        this.addProduto = function(req, callback){
            let produto = req.body;
            produtoModel.insert(produto, connection, callback);
        };

        this.getProduto = function(id, callback){
            produtoModel.getById(connection, id, callback);
        }

        this.updateProduto = function(req, id, callback){    
            let produto = req.body;
            produtoModel.updade(produto, connection, id, callback)
        }
    }
}

module.exports = ProdutoController;