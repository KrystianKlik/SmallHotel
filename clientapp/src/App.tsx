import "./App.css";
import { BrowserRouter as Router, Switch, Route, Link } from "react-router-dom";
import Customer from "./Pages/Customer";
import Manager from "./Pages/Manager";

function App() {

  async function checkIfThereIsBooking() {
    const response = await fetch('');
  }

  return (
    <Router>
      <div className="App">
      {/* <header className="App-header"></header> */}
        <Switch>
          <Route exact path="/">
            <Customer />
          </Route>
          <Route path="/manager">
            <Manager />
          </Route>
        </Switch>
      </div>
    </Router>
  );
}

export default App;
