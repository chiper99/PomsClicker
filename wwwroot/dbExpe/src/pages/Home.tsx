import { IonContent, IonHeader, IonPage, IonTitle, IonToolbar, IonImg } from '@ionic/react';
import React from 'react';
import './ChooseModePageStyle.css';

const Home: React.FC = () => {
  return (
    <IonPage>
      <IonHeader>
      </IonHeader>
      <IonContent>
        <div id = "ChooseModePage">
          <h6 id="HelloUsername">Hello, [username] !</h6>

          <h6 id="ChooseMode">Choose your mode please:</h6>

          <h6 id="SinglePlayer">Single Player</h6>

          <IonImg id="ApplePic" src='./Assets/Apple.png' alt = 'Apple'/>

          <h6 id="Multiplayer">Multiplayer</h6>

          <div>
            <img id="AppleMulti" src='Assets/AppleMulti-07.jpg' alt = 'Apple Multi'/>

            <img id="AppleReverse" src='Assets/AppleReverse-07.jpg' alt = 'Apple Reverse'/>
          </div>

          <h6 id="Blitz">Blitz</h6>

          <div>
            <img id="AppleBlitz" src='Assets/AppleMulti-07.jpg' alt = 'Apple Multi'/>
            <img id="Cherry" src='Assets/Cherry.jpg' alt = 'Cherry'/>
           <img id="Lemon" src='Assets/Lemon.jpg' alt = 'lemon'/>
          </div>

        </div>
      </IonContent>
    </IonPage>
  );
};

export default Home;
