import React, { Component } from 'react';
import { View, Text, FlatList, Modal, Alert, TouchableOpacity } from 'react-native';
//import CheckBox from '@react-native-community/checkbox';
import api from '../services/api';
import Styles from './styles';



class Item extends Component{
    state = {
        item: this.props.item
    }
    render(){
        

        return(
            <TouchableOpacity 
                style={this.props.selected ? Styles.selectedListItem : Styles.listItem} 
                onLongPress={() => this.props.onClick()}
            >
                <Text style={{
                    fontWeight: "bold",
                    fontSize: 22,
                    marginLeft: 5
                }}>{this.state.item.nome}</Text>
                <Text style={{
                    color: '#999',
                    marginLeft: 5
                }}>{this.state.item.descricao}</Text>
              
            </TouchableOpacity>
        )
    }
}

export default class List extends Component{

    state = {
        products: null,
        isProductSelected: false,
        selected: null,
        isStockList: false
    }

    componentDidMount(){
        ///se for uma venda carregar a lista de compras, se for uma compra, carregar lista...
        //...carregar lista de produtos.
        const url = this.props.route.name === 'ProductList' ? 
        'produtos' : 'produtos_transacoes';
        this.loadData(url);
    }

    loadData = async (url) => { 
        try{
            var response = await api.get(url);
        }catch(error){
            console.log(error)
        }

        this.setState({
            products: response.data,
            isStockList: url != 'produtos'
        })

        
    }
    
    ///para deixar o produto selecionado
    select = (item) => {
        this.setState({
            isProductSelected: true, //controla se o modal com a opção de avançar aparece
            selected: item
        });
    }

    render(){

        return(
        <View>
            <Text style={Styles.title}>Escolha o produto e segure</Text>
            <FlatList
                data={this.state.products}
                renderItem={({item}) => (
                    <Item
                        isStockList={this.state.isStockList}
                        item={item}
                        selected={this.state.selected && this.state.selected.id == item.id}
                        onClick={() => this.select(item)}
                    />
                )}
                keyExtractor={item => item.id.toString()}
            />

            <Modal
                visible={this.state.isProductSelected}
                transparent={true}
                animationType='slide'
                onRequestClose={() => {
                    Alert.alert("");
                }}
            >
                <View style={Styles.container}>
                    <View style={Styles.nextBox}>
                        
                        <Text>{this.state.selected ? 
                        `Registrar transação de ${this.state.selected.nome}?` : '' }</Text>
                        <View style={{flexDirection: 'row'}}>
                            <TouchableOpacity 
                                style={Styles.buttonInRow}
                                onPress={() => {
                                    this.setState({
                                        isProductSelected: false,
                                        selected: null
                                    })
                                    this.props.navigation.navigate('NewTransaction',
                                    {product: this.state.selected, 
                                    sale: this.state.isStockList})

                                }}
                            >
                                <Text>Avançar</Text>
                            </TouchableOpacity>

                            <TouchableOpacity 
                                style={Styles.buttonInRow}
                                onPress={() => {
                                    this.setState({
                                        isProductSelected: false,
                                        selected: null
                                    })
                                }}
                            >
                                <Text>Cancelar</Text>
                            </TouchableOpacity>
                        </View>
                    </View>
                </View>
            </Modal>
        </View>

        
        )
    }
}

