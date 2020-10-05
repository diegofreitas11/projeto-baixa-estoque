import React, { Component } from 'react';
import { View, Text, FlatList } from 'react-native';
import { TouchableOpacity } from 'react-native-gesture-handler';
import Styles from './styles';


export default class Main extends Component{
    constructor(props){
        super(props);
    }
    render(){
        return(
        <View style={{
            flex:1,
            alignItems: 'center',
            justifyContent: 'center'
        }}>
            <Text style={Styles.title}>Bem-vindo</Text>
            <TouchableOpacity
                style={{
                    height: 50,
                    width: 200,
                    borderWidth: 0.5,
                    borderRadius: 20,
                    backgroundColor: '#cecece',
                    borderColor: '#cecece',
                    shadowColor: '#cecece',
                    elevation: 4,
                    justifyContent: 'center',
                    alignItems: 'center'
                }}
                onPress={() => this.props.navigation.navigate('Menu')}
            >
                <Text style={{
                    color: 'white',
                    fontFamily: 'roboto',
                    fontWeight: 'bold',
                    
                }}>Começar</Text>
            </TouchableOpacity>
        </View>
        )
    }   
}