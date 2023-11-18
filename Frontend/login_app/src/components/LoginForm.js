import { useState } from "react";
import "./LoginForm.css";

export const LoginForm = ({loginAttempts, setLoginAttempts}) => {
    const [usernameValue, setUsernameValue] = useState("");
    const [passwordValue, setPasswordValue] = useState("");

    const handleUsernameChange = (event) => {
        setUsernameValue(event.target.value);
    }

    const handlePasswordChange = (event) => {
        setPasswordValue(event.target.value);
    }

    const handleReset = () => {
        setUsernameValue("");
        setPasswordValue("");
    }

    const handleSubmit = (event) => {
        event.preventDefault();
        
        console.log("handleSubmit");
        console.log(usernameValue);

        const loginAttempt = {
            username: usernameValue,
            pass: passwordValue
        }
        setLoginAttempts([...loginAttempts, loginAttempt]);
        handleReset();
    }

  return (

    <form className="form" onSubmit={handleSubmit}>
        <h1>Login</h1>
        <label htmlFor="name">Name</label>
        <input onChange={handleUsernameChange} type="text" id="name" value={usernameValue} />
        <label htmlFor="password">Password</label>
        <input onChange={handlePasswordChange} type="password" id="password" value={passwordValue} />
        <button type="submit">Continue</button>
    </form>
  )
}