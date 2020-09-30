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
                        borderWidth: 0.5,
                        borderColor: "#cecece",
                        borderRadius: 5,
                        height: 100,
                        margin: 5,
                        shadowColor: '#cecece',
                        elevation: 5,
                        padding: 5
                    }}>
                        <Text style={{
                            fontWeight: "bold",
                            fontSize: 22,
                            marginLeft: 5
                        }}>{item.nome}</Text>
                        <Text style={{
                            color: '#999',
                            marginLeft: 5
                        }}>{item.descricao}</Text>
                    </View>
                )}
                keyExtractor={item => item.id}
            />
        </View>
        )
    }
}