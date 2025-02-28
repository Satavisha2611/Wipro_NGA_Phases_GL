import { useState } from "react";

const Button2 = () => {
    const[firstName, setfirstName] = useState('');
    const update = () => {
        setfirstName("Satavisha");
    };
    return(
        <div>First name is: {firstName}<br />
        <input type="button" value="change" onClick={update} />
        </div>
    )
};

export default Button2;