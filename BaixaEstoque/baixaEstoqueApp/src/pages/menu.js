import { NavigationContainer } from '@react-navigation/native';
import React from 'react';
import { Text } from 'react-native';
import { createDrawerNavigator } from '@react-navigation/drawer';
import { createStackNavigator } from '@react-navigation/stack';
import List from './list';
import NewProduct from './newProduct';
import NewPurchase from './newPurchase';


const Drawer = createDrawerNavigator();

const Stack = createStackNavigator();


const NewPurchaseStack = () => {
    return(
        <Stack.Navigator initialRouteName="List" headerMode="none">
            <Stack.Screen 
                name="List"
                component={List}
            />
            <Stack.Screen 
                name="NewPurchase"
                component={NewPurchase}
            />
        </Stack.Navigator>
    )
}


const Menu = () => {
    return(
      
            <Drawer.Navigator initialRouteName="NewProduct">
                
                <Drawer.Screen 
                    name="NewProduct" 
                    component={NewProduct}
                    options={{
                        drawerLabel: (() => <Text> Novo Produto</Text>)
                    }}
                />

                <Drawer.Screen 
                    name="newPurchaseStack" 
                    component={NewPurchaseStack}
                    options={{
                        drawerLabel: (() => <Text> Nova Compra</Text>)
                    }}
                />
                
            </Drawer.Navigator>
     
        
    )
}

export default Menu;