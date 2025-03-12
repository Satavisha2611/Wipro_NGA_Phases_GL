var express = require("express");
var bodyParser = require("body-parser");
var cors = require("cors");
var app = express();

app.use(cors());
app.use(bodyParser.json());

let students = [
    {"studentid":1, "name":'Satavisha', "Grade":'A'},
    {"studentid":2, "name":'Raj', "Grade":'C'},
    {"studentid":3, "name":'Shruti', "Grade":'A'},
    {"studentid":4, "name":'Sakshi', "Grade":'A'},
]

app.get("/showstudent", (req,res) => {
    res.status(200).json(students);
})

app.get("/searchstudentbyid/:studentid", (req, res) => {
    let found = students.find(function (item) {
        return item.studentid === parseInt(req.params.studentid);
    });
    if (found) {
        res.status(200).json(found);
    } else {
        res.sendStatus(404);
    }
})

app.get("/searchstudentbyname/:name", (req, res) => {
    let found = students.find(function (item) {
        return item.name === req.params.name;
    });
    if (found) {
        res.status(200).json(found);
    } else {
        res.sendStatus(404);
    }
})

app.get("/searchstudentbygrade/:Grade", (req, res) => {
    let found = students.find(function (item) {
        return item.Grade === req.params.Grade;
    });
    if (found) {
        res.status(200).json(found);
    } else {
        res.sendStatus(404);
    }
})

app.listen(1114, (req, res) => {
    console.log("Node Js Application started...");
})