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
const isLoggedIn = true;
const App: React.FC = () => (
  <IonApp>
    <IonReactRouter>
      <IonRouterOutlet>
        <Route path="/home" isLoggedIn component={Home} exact={true} />
        <Route path="/blitz" component={Blitz} exact={true} />
        <Route path="/multi" component={Multi} exact={true} />
        <Route path="/single" component={Single} exact={true} />
        <Route path="/login" component={LoginPage} exact={true} />     
        <Route path="/register" component={RegisterPage} exact={true} />             
        <Route exact path="/" render={() => isLoggedIn ? <Redirect to="/home" /> : <Redirect to="/login" />} />
      </IonRouterOutlet>      
    </IonReactRouter>
  </IonApp>
);




export default App;
