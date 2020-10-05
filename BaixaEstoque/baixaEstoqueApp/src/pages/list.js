import React, { Component } from 'react';
import { View, Text, FlatList, Modal, Alert, TouchableOpacity } from 'react-native';
//import CheckBox from '@react-native-community/checkbox';
import api from '../services/api';
import Styles from './styles';

export default class List extends Component{

    state = {
        products: null,
        isProductSelected: false,
        selected: null
    }

    componentDidMount(){
        this.loadData();
    }

    loadData = async () => {
        try{
            var response = await api.get('produtos');

        }catch(error){
            console.log(error)
        }

        this.setState({
            products: response.data
        })
    }
    

    render(){
        return(
        <View>
            <Text style={Styles.title}>Escolha o produto e segure</Text>
            <FlatList
                data={this.state.products}
                renderItem={({item}) => (
                    <TouchableOpacity 
                        style={this.state.selected && this.state.selected.id == item.id ?
                             Styles.selectedListItem : Styles.listItem} 
                        onLongPress={() => {
                            this.setState({
                                isProductSelected: true,
                                selected: item
                            });
                        }}
                    >
                        <Text style={{
                            fontWeight: "bold",
                            fontSize: 22,
                            marginLeft: 5
                        }}>{item.nome}</Text>
                        <Text style={{
                            color: '#999',
                            marginLeft: 5
                        }}>{item.descricao}</Text>
                        
                    </TouchableOpacity>
                )}
                keyExtractor={item => item.id}
            />

            <Modal
                visible={this.state.isProductSelected}
                transparent={true}
                animationType='slide'
                onRequestClose={() => {
                    Alert.alert("Modal has been closed.");
                }}
            >
                <View style={Styles.container}>
                    <View style={Styles.nextBox}>
                        
                        <Text>{this.state.selected ? 
                        `Registrar compra de ${this.state.selected.nome}?` : '' }</Text>
                        <View style={{flexDirection: 'row'}}>
                            <TouchableOpacity 
                                style={Styles.buttonInRow}
                                onPress={() => {
                                    this.setState({
                                        isProductSelected: false,
                                        selected: null
                                    })
                                    this.props.navigation.navigate('NewPurchase',
                                    {product: this.state.selected})

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