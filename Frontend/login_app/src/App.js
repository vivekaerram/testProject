import { useState } from "react";
import './App.css';
import { LoginForm } from './components/LoginForm';
import { LoginAttemptList } from "./components/LoginAttemptList";

const App = () => {
  const [loginAttempts, setLoginAttempts] = useState([]);

  return (
    <div className="App">
      <LoginForm loginAttempts={loginAttempts} setLoginAttempts={setLoginAttempts} />
      <LoginAttemptList key={loginAttempts.length} loginAttempts={loginAttempts} setLoginAttempts={setLoginAttempts} />
    </div>
  );
};

export default App;
