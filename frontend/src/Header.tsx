import React from 'react';

interface HeaderProps {
  title: string;
}

const Header: React.FC<HeaderProps> = ({ title }) => {
  return (
    <header className="App-header text-white py-5">
      <div className="container">
        <div className="row">
          <div className="col-md-10">
            <h1 className="display-4">{title}</h1>
            <p className="text-center">
              Welcome to our epic bowling league! View the Marlins and the
              Sharks!
            </p>
          </div>
        </div>
      </div>
    </header>
  );
};

export default Header;
