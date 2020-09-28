import React, { Component } from 'react';
import { View, Text, FlatList } from 'react-native';
import api from '../services/api';

export default class Main extends Component{

    state = {
        produtos: null
    }

    componentDidMount(){
        this.loadData();
    }

    loadData = async () => {
        try{
            var response = await api.get('produtos');
            console.log(response.data);
        }catch(error){
            console.log(error)
        }

        this.setState({
            produtos: response.data
        })
    }

    render(){
        return(
        <View>
            <FlatList
                data={this.state.produtos}
                renderItem={({item}) => (
                    <View style={{
                        borderWidth: 1,
                        borderRadius: 5,
                        height: 100
                    }}>
                        <Text style={{
                            fontWeight: "bold",
                            fontSize: 22
                        }}>{item.nome}</Text>
                        <Text style={{
                            color: '#999'
                        }}>{item.descricao}</Text>
                    </View>
                )}
                keyExtractor={item => item.id}
            />
        </View>
        )
    }
}