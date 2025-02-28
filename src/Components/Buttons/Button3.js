import { useState } from "react";

const Button3 = () =>
{
    const [firstName] = useState("Satavisha");
    const show =()=>{
        alert(`First name is: Satavisha`);
    };
    return(
       <div> <input type="button" value="Show" onClick={show} /> </div>
    )
}

export default Button3;