const mysql = require('mysql');

class ProdutoModel{
    constructor(){
        this.getAll = function(connection, callback){
            connection.query("select * from produto", callback);
        }

        this.getById = function(connection, id, callback){
            connection.query("select * from produto where id="+id, callback)
        }

        this.insert = function(produto, connection, callback){
            connection.query('insert into produto set ?', produto, callback);
        }

        this.updade = function(produto, connection, id, callback){
            connection.query('update produto set ? where id = ?', [produto, id], callback);
        }

        this.join = function(connection, callback){
            connection.query("select produto.id as produto, produto.nome as nome, compra.id as id,"+
            " compra.quantidade_disp as quantidade_disp, compra.valor_unit as valor_unit" +
            " from produto join compra on produto.id = compra.produto and quantidade_disp > 0", callback);
        }
     }
}

module.exports = ProdutoModel;


//const conection = require('./dbConnection');



