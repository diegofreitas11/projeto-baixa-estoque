const { Model, DataTypes } = require('sequelize');


class Transacao extends Model{
    static init(sequelize){
        super.init({
            tipo: DataTypes.STRING,
            valor: DataTypes.FLOAT,
            quantidade: DataTypes.INTEGER,
            metodo: DataTypes.INTEGER
        },{
            sequelize,
            tableName: 'transacoes'
        })

    }
    
}

module.exports = Transacao;