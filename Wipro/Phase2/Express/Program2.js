var express = require("express")
var bodyParser = require("body-parser")
var cors = require("cors")
var app = express()

app.use(cors());
app.use(bodyParser.json());
let employs = [
    {"empno":1,"name":"Prasanna","basic":88234},
    {"empno":2,"name":"Rajesh","basic":90032},
    {"empno":3,"name":"Kalyan","basic":91153},
    {"empno":4,"name":"Abhishiek","basic":90023},
    {"empno":5,"name":"Srikar","basic":98823},
]

app.get("/showEmployee", (req,res)=>{
    res.status(200).json(employs)
})

app.listen(1119,(req,res)=>{
    console.log("Application has started in port 1115");
 })