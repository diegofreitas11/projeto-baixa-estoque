import {StyleSheet} from 'react-native';

export default Styles = StyleSheet.create({
    container: {
        justifyContent: 'center',
        alignItems: 'center',
        flex: 1
    },
    title:{
        fontFamily: 'roboto',
        fontWeight: 'bold',
        fontSize: 22,
        marginBottom: 10
    },
    inputLabel: {
        fontFamily: 'roboto',
        marginTop: 10
    },
    input: {
        borderBottomWidth: 1
    },
    button: {
        borderWidth: 1,
        borderRadius: 5,
        padding: 5,
        marginTop: 20,
        width: 200,
        height: 50,
        alignItems: 'center',
        justifyContent: 'center',
        alignSelf: 'center'
    },
    buttonInRow: {
        borderRadius: 5,
        backgroundColor: '#0B243B',
        padding: 5,
        margin: 20,
        width: 100,
        height: 50,
        alignItems: 'center',
        justifyContent: 'center',
        
    },
    listItem: {
        borderWidth: 0.5,
        borderColor: "#cecece",
        borderRadius: 5,
        height: 100,
        margin: 5,
        shadowColor: '#cecece',
        elevation: 5,
        padding: 10
    },
    selectedListItem:{
        borderWidth: 0.5,
        borderColor: "#cecece",
        backgroundColor: "#cecece",
        borderRadius: 5,
        height: 100,
        margin: 5,
        shadowColor: '#cecece',
        elevation: 5,
        padding: 5
    },
    nextBox: {
        alignItems: 'center',
        position: 'absolute',
        backgroundColor: '#E6E6E6',
        bottom: 0,
        height: 100,
        width: '100%',
        padding: 3,
    },
    successBox: {
        justifyContent: 'center',
        alignItems: 'center',
        height: 150,
        width: 250,
        borderColor: '#00FA9A',
        borderWidth: 2,
        backgroundColor: 'white',
        borderRadius: 20,
        shadowColor: '#000',
        elevation: 5,
        padding: 5,
    },
    methodText: {
        alignSelf: 'center',
        fontWeight: 'bold',
        fontSize: 20
    },
    entryCard: {
        flexDirection: 'row',
        borderBottomWidth: .5,
        height: 50,
        width: '100%'
    },
    entryData: {
        width: '33%',
    }
})