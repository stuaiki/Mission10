import React from 'react';
import './App.css';
import Header from './Header';
import BowlerList from './Bowler/BowlerList';
import 'bootstrap/dist/css/bootstrap.min.css';

function App() {
  return (
    <div className="App">
      <Header title="Bowler's Information" />
      <br />
      <BowlerList />
    </div>
  );
}

export default App;
