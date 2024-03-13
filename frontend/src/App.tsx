// This is Mission 10 assignment
// Aiki Takaku
// Section 3
// This is a full stack assignment
import React from 'react';
import './App.css';
import Header from './Header';
import BowlerList from './Bowler/BowlerList';
import 'bootstrap/dist/css/bootstrap.min.css';

//This is a default function to run in react. call header and bowlerlist function to display
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
