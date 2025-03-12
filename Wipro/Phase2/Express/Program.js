var express = require("express")
var app = express() // ensures express js program i want to run

// app.use()

app.get("/", (req,res) => {
  res.send("This is my first express js page....");
})

app.get("/showFullName/:FirstName/:LastName", (req,res) => {
    const firstName = req.params.FirstName;
    const lastName = req.params.LastName;
    let fullName = firstName+" "+lastName;
    res.send(`Full name is : ${fullName}`);
})

app.get("/showinfo/:city/:company", (req,res)=>{
    const city = req.params.city;
    const company = req.params.company;
    res.send(`City is ${city}. Company is ${company}`)
})

app.get("/showName/:name",(req,res)=>{
   res.send(`My name is ${req.params.name}`)
})

app.listen(1115,(req,res)=>{
   console.log("Application has started in port 1115");
})