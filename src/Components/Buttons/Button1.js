import { useState } from "react"


const Button1= () => {
    const[firstName] =useState("Satavisha");
    return(
        <div><b>First name is : {firstName}</b></div>
    )
}

export default Button1;