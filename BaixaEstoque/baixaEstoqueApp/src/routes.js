import { createStackNavigator } from 'react-navigation-stack';
import Main from './pages/main';
import NewProduct from './pages/newProduct'

const Root = createStackNavigator({
    NewProduct,
    Main
},{
    defaultNavigationOptions: {
        headerShown: false
    },
});

export default Root;