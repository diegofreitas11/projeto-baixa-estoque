import  React,{ Component } from 'react';
import {View, Text, FlatList, TouchableOpacity} from 'react-native';
import Styles from './styles';
import AdvanceModal from './advanceModal';

const methods = ['Média Ponderada', 'UEPS', 'PEPS']

export default class MethodPick extends Component{

    state = {
        isAMethodSelected: false,
        selected: null
    }

    select = (item) => {
        console.log(item)
        this.setState({
            isAMethodSelected: true,
            selected: item
        })
    }

    advance = () => {
        this.setState({
            isAMethodSelected: false,
            selected: null
        })
        this.props.navigation.navigate('NewTransaction', 
            {...this.props.route.params,
            method: this.state.selected})
    }

    cancel = () => {
        this.setState({
            isProductSelected: false,
            selected: null
        })
    }

    render(){
        return(
            <View>
                <FlatList 
                    data={methods}
                    renderItem={({item}) =>(
                        <TouchableOpacity 
                            style={this.state.selected && this.state.selected === item ?
                            {...Styles.selectedListItem, justifyContent: 'center'}: 
                            {...Styles.listItem, justifyContent: 'center'}}
                            onPress={() => this.select(item)}
                        >
                        
                            <Text style={Styles.methodText}>{item}</Text>
                        </TouchableOpacity>
                    )}
                    keyExtractor={(item, index) => index.toString()}
                    
                />

                <AdvanceModal
                    visible={this.state.isAMethodSelected}
                    message={`Usar o método ${this.state.selected}`}
                    advance={() => this.advance}
                    cancel={() => this.cancel}
                />
            </View>


        )
    }
}