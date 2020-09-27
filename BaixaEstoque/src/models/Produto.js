const { Model, DataTypes } = require('sequelize');


class Produto extends Model{
  static init(sequelize) {
    super.init({
        nome: DataTypes.STRING,
        descricao: DataTypes.STRING
    },{
        sequelize,
        tableName: 'produtos'
    })
  }
  static associate(models){
      this.hasMany(models.Transacao, {foreignKey: 'produto_id', as: 'transacoes'})
  }
  
}

module.exports = Produto;
  

