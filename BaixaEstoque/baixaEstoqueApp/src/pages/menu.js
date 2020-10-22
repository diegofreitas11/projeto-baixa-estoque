import { NavigationContainer, DrawerActions } from '@react-navigation/native';
import React from 'react';
import { createDrawerNavigator } from '@react-navigation/drawer';
import { createStackNavigator } from '@react-navigation/stack';
import { createBottomTabNavigator } from '@react-navigation/bottom-tabs'
import ProductPick from './productPick';
import NewProduct from './newProduct';
import List from './list';
import NewTransaction from './newTransaction';
import MethodPick from './methodPick';
import { TouchableOpacity, Text } from 'react-native';
import FontAwesome from 'react-native-vector-icons/FontAwesome';
import Fontisto from 'react-native-vector-icons/Fontisto';


const Drawer = createDrawerNavigator();
const Stack = createStackNavigator();
const Tab = createBottomTabNavigator();

const navOptions = ({navigation}) => ({
    title: '',
    headerStyle: {backgroundColor: 'white', elevation: 0},
    headerLeft: () => (
        <TouchableOpacity 
            onPress={() => navigation.dispatch(DrawerActions.toggleDrawer())}
            style={{padding: 5}}
        >
            <FontAwesome name='bars' size={30} color='#000'/>
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
                component={ProductPick}
                
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
                component={ProductPick}
                
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

const ListTabs = () => {
    return(
        <Tab.Navigator
            screenOptions={() => ({
                tabBarIcon: ({ color, size }) => {
                    return <Fontisto name={'table-2'} size={size} color={color}/>
                },
            })}
            tabBarOptions={{
                activeTintColor: 'green',
                inactiveTintColor: 'black'
            }}
        >
            <Tab.Screen name='Entradas' component={List}/>
            <Tab.Screen name='Saídas' component={List}/>
        </Tab.Navigator>
    )
}

const Menu = () => {
    return(
        <Drawer.Navigator 
            initialRouteName="ListTabs"
        >
            <Drawer.Screen
                name="ListTabs"
                component={ListTabs}
                options={{
                    drawerLabel: (() => <Text> Tabs </Text>),
                }}
            />

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