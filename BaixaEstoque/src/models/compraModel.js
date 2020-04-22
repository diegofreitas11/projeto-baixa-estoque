
class CompraModel{
    constructor(){
        this.getAll = function(connection, callback){
            connection.query("select * from compra", callback);
        }

        this.getById = function(connection, id, callback){
            connection.query("select * from compra where id="+id, callback)
        }

        this.insert = function(compra, connection, callback){           
            connection.query('insert into compra set ?, quantidade_disp=?', 
                [compra, compra.quantidade], callback);
        }

        this.updade = function(transacao, connection, id){
            connection.query('update compra set ? where id = ?', [transacao, id]);
        }
         
    }
}

module.exports = CompraModel;