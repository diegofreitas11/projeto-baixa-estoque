import { NavigationContainer, DrawerActions } from '@react-navigation/native';
import React from 'react';
import { createDrawerNavigator } from '@react-navigation/drawer';
import { createStackNavigator } from '@react-navigation/stack';
import List from './list';
import NewProduct from './newProduct';
import NewTransaction from './newTransaction';
import MethodPick from './methodPick';
import { TouchableOpacity, Text } from 'react-native';
import Icon from 'react-native-vector-icons/FontAwesome';


const Drawer = createDrawerNavigator();
const Stack = createStackNavigator();

const navOptions = ({navigation}) => ({
    title: '',
    headerStyle: {backgroundColor: 'white', elevation: 0},
    headerLeft: () => (
        <TouchableOpacity 
            onPress={() => navigation.dispatch(DrawerActions.toggleDrawer())}
            style={{padding: 5}}
        >
            <Icon name='bars' size={30} color='#000'/>
        </TouchableOpacity>
    )
})


const NewProductStack = () => {
    return(
        <Stack.Navigator 
            initialRouteName="ProductList" 
            headerMode="screen"
            screenOptions={navOptions}
        >
            <Stack.Screen 
                name="NewProduct" 
                component={NewProduct}  
            />
            
        </Stack.Navigator>
    )
}

const NewPurchaseStack = () => {
    return(
        <Stack.Navigator 
            initialRouteName="ProductList" 
            headerMode="screen"
            screenOptions={navOptions}
        >
            <Stack.Screen 
                name="ProductList"
                component={List}
                
            />
            <Stack.Screen 
                name="NewTransaction"
                component={NewTransaction}
            />
        </Stack.Navigator>
    )
}

const NewSaleStack = () => {
    return(
        <Stack.Navigator 
            initialRouteName="StocktList" 
            headerMode="screen"
            screenOptions={navOptions}
        >

            <Stack.Screen 
                name="StockList"
                component={List}
                
            />
            <Stack.Screen 
                name="MethodPick"
                component={MethodPick}
                
            />
            <Stack.Screen 
                name="NewTransaction"
                component={NewTransaction}
            />
        </Stack.Navigator>
    )
}

const Menu = () => {
    return(
        <Drawer.Navigator 
            initialRouteName="NewProduct"
        >
            <Drawer.Screen 
                name="NewProductStack" 
                component={NewProductStack}
                options={{
                    drawerLabel: (() => <Text> Novo Produto</Text>),
                }}
            />

            <Drawer.Screen 
                name="NewPurchaseStack" 
                component={NewPurchaseStack}
                options={{
                    drawerLabel: (() => <Text> Nova Compra</Text>),
                }}
            />

            <Drawer.Screen 
                name="NewSaleStack" 
                component={NewSaleStack}
                options={{
                    drawerLabel: (() => <Text> Nova Venda </Text>),                        
                }}
            />
            
        </Drawer.Navigator>
     
        
    )
}

export default Menu;