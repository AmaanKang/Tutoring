﻿import React from "react";
import
{ useAuth0 }
from "@auth0/auth0-react";
/**
 * Creates Log out button that logs the user out
 * */
const LogoutButton = () => {
const { logout } = useAuth0();

return (

    < button className="btn btn-info" onClick ={ () => logout({ returnTo: window.location.origin })}>
    Log Out
  </ button >
  );
};

export default LogoutButton;
