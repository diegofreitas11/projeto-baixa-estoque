class VendaModel{
    constructor(){
        
        this.getAll = function(connection, callback){
            connection.query("select * from venda", callback);
        }

        this.getById = function(connection, id, callback){
            connection.query("select * from venda where id="+id, callback)
        }

        this.insert = function(venda, connection, callback){
            connection.query('insert into venda set ?',venda, callback);
        }

        this.updade = function(venda, connection, id, callback){
            connection.query('update venda ? where id = ?', [venda, id], callback);
        }
         
    }
}

module.exports = VendaModel;