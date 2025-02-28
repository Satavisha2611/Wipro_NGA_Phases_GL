import logo from './logo.svg';
import './App.css';
import First from './Components/First/First';
import Second from './Components/Second/Second';
import Button1 from './Components/Buttons/Button1';
import Button2 from './Components/Buttons/Button2';
import Button3 from './Components/Buttons/Button3';

function App() {
  return (
    <div className="App">
     <p> I am Satavisha..</p><br />
     <First /> <br />
     <Second firstName = "Satavisha" lastName="Chakraborty" company="Wipro"/><br />
     <Button1 /> <br /> <hr />
     <Button2 /><br />
     <Button3 />
    </div>
  );
}

export default App;
