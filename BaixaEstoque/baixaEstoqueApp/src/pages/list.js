import React, { Component } from 'react';
import { FlatList, View, Text, ScrollView } from 'react-native';
import api from '../services/api';
import Styles from './styles';
export default class List extends Component{
    state = {
        entries: null
    }

    componentDidMount(){
        this.loadData();
    }

    loadData = async () => {
        var type = this.props.route.name === "Entradas" ? 'compra' : 'venda';
        try{
            var response = await api.get(`/produtos_transacoes/${type}`);
        }catch(error){
            console.log(error);
        }

        console.log(response.data)
        this.setState({
            entries: response.data
        })
        
    }

    render(){
        
       var products = this.state.entries ? this.state.entries.map((item) => (
            <View>
                <Text style={Styles.title}>{item.nome}</Text>
                <View style={Styles.entryCard}>
                        <Text style={{...Styles.entryData, fontWeight: 'bold'}}>ID</Text>
                        <Text style={{...Styles.entryData, fontWeight: 'bold'}}>Valor</Text>
                        <Text style={{...Styles.entryData, fontWeight: 'bold'}}>Quantidade</Text>
                    </View>
                {item.transacoes.map((entry) =>(
                    <View style={Styles.entryCard}>
                        <Text style={Styles.entryData}>{entry.id}</Text>
                        <Text style={Styles.entryData}>{entry.valor.toFixed(2)}</Text>
                        <Text style={Styles.entryData}>{entry.quantidade}</Text>
                    </View>
                ))}
            </View>
        )) : null


        return(
            <ScrollView style={{padding: 10}}>
                {products}
            </ScrollView>
        )
       
        }
}