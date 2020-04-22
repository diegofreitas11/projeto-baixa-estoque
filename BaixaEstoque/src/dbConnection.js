const mysql = require('mysql');


const connection = mysql.createConnection({
    host: "localhost",
    user: "diego",
    password: "23ty12opskfd",
    database: "baixaestoque"
 });

connection.connect(err => {
    if(err)
        return console.log(err);
    return console.log('blz!');
});
   

module.exports = connection;