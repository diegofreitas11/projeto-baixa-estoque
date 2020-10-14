import { NavigationContainer } from '@react-navigation/native';
import React from 'react';
import { Text } from 'react-native';
import { createDrawerNavigator } from '@react-navigation/drawer';
import { createStackNavigator } from '@react-navigation/stack';
import List from './list';
import NewProduct from './newProduct';
import NewTransaction from './newTransaction';


const Drawer = createDrawerNavigator();

const Stack1 = createStackNavigator();
const Stack2 = createStackNavigator();


const NewPurchaseStack = () => {
    return(
        <Stack1.Navigator initialRouteName="ProductList" headerMode="none">
            <Stack1.Screen 
                name="ProductList"
                component={List}
                
            />
            <Stack1.Screen 
                name="NewTransaction"
                component={NewTransaction}
            />
        </Stack1.Navigator>
    )
}

const NewSaleStack = () => {
    return(
        <Stack2.Navigator initialRouteName="StocktList" headerMode="none">
            <Stack2.Screen 
                name="StockList"
                component={List}
                
            />
            <Stack2.Screen 
                name="NewTransaction"
                component={NewTransaction}
            />
        </Stack2.Navigator>
    )
}

const Menu = () => {
    return(
      
            <Drawer.Navigator 
                initialRouteName="NewProduct"
            >
                
                <Drawer.Screen 
                    name="NewProduct" 
                    component={NewProduct}
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