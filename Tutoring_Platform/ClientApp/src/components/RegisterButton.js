﻿import React from "react";
import { useAuth0 } from "@auth0/auth0-react";
/**
 * Creates Register button that registers the user with redirect
 * */
const RegisterButton = () => {
    const { loginWithRedirect } = useAuth0();

    return < button className="btn btn-info" onClick={() => loginWithRedirect()}> Register </ button >;
};

export default RegisterButton;
