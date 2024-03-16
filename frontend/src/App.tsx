import React from 'react';
import './App.css';

import Header from './Header';
import BowlersTable from './Bowler/BowlersTable';

function App() {
  return (
    <div className="App">
      <Header title="Welcome to Barbara and David's Bowling League!" />
      <BowlersTable />
    </div>
  );
}

export default App;
