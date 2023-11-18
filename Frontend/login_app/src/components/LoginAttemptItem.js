export const LoginAttemptItem = ({ loginAttempt }) => {
  return (
    <>
      <li>
          <span>{loginAttempt.username} - {loginAttempt.password}</span>
      </li>
    </>
  )
}
