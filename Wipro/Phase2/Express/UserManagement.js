var express = require ('express');
var bodyParser = require ('body-parser');
var cors = require('cors');
var app = express();
app.use(cors());
app.use(bodyParser.json());

var users = [
    { "userId": 1, "userName" : 'Satavisha', "userMail":'Sat123@gmail.com' },
    { "userId": 2, "userName" : 'Sakshi',"userMail":'Sak123@gmail.com' },
    { "userId": 3, "userName" : 'Shruti', "userMail":'Sti123@gmail.com' },
    { "userId": 4, "userName" : 'Prakash',"userMail":'Kash123@gmail.com' }
]

app.get("/showUser",(req,res)=>{
    res.status(200).json(users)
})

app.post("/addUser",function(req,res){
    let newUser = {
        userId : parseInt (req.body.userId),
        userName : req.body.userName,
        userMail : req.body.userMail
    }

    users.push(newUser);

    res.status(201).json({
        'message': "successfully created"
    });
    
})

app.get("/searchUser/:userId", (req,res)=>{
    let found = users.find(function(item){
        return item.userId === parseInt(req.params.userId);
    })

    if (found) {
        res.status(200).json(found)
    } else {
        res.send(404);
    }
})

app.listen(2250, (req, res) => {
    console.log("Node Js Application Started...http://localhost:2250");
})