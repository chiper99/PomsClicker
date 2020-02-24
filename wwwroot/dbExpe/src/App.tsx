import React from 'react';
import { Redirect, Route } from 'react-router-dom';
import { IonApp, IonRouterOutlet} from '@ionic/react';
import { IonReactRouter } from '@ionic/react-router';
import Home from './pages/Home';
import Blitz from './pages/blitz-mode';
import Single from './pages/single-player-mode';
import Multi from './pages/multi-player-mode';
import LoginPage from './pages/login-page';
import RegisterPage from './pages/register-page';

/* Core CSS required for Ionic components to work properly */
import '@ionic/react/css/core.css';

/* Basic CSS for apps built with Ionic */
import '@ionic/react/css/normalize.css';
import '@ionic/react/css/structure.css';
import '@ionic/react/css/typography.css';

/* Optional CSS utils that can be commented out */
import '@ionic/react/css/padding.css';
import '@ionic/react/css/float-elements.css';
import '@ionic/react/css/text-alignment.css';
import '@ionic/react/css/text-transformation.css';
import '@ionic/react/css/flex-utils.css';
import '@ionic/react/css/display.css';

/* Theme variables */
import './theme/variables.css';
const isLoggedIn = false;
const App: React.FC = () => (
  <IonApp>
    <IonReactRouter>
      <IonRouterOutlet>
        <Route exact path="/home" render ={props =>{return isLoggedIn ? <Home/> : <LoginPage/>}} />
        <Route exact path="/blitz" render={props =>{return isLoggedIn ? <Blitz/> : <LoginPage/>}} />
        <Route exact path="/multi" render={props =>{return isLoggedIn ? <Multi/> : <LoginPage/>}} />
        <Route exact path="/single" render={props =>{return isLoggedIn ? <Single/> : <LoginPage/>}}/>
        <Route exact path="/login" render={props =>{return isLoggedIn ? <Home/> : <LoginPage/>}} />  
        <Route exact path="/register" render={props =>{return isLoggedIn ? <Home/> : <RegisterPage/>}} />            
        <Route exact path="/" render={() => isLoggedIn ? <Redirect to="/home" /> : <Redirect to="/login" />} />
      </IonRouterOutlet>      
    </IonReactRouter>
  </IonApp>
);




export default App;
