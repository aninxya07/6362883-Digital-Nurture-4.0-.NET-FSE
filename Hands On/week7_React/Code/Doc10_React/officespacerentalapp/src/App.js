import React from "react";
import "./App.css";

import imgDBS from "./images/dbs.jpg";
import imgRegus from "./images/regus.jpg";
import imgWeWork from "./images/wework.jpg";

function App() {
  const element = "Office Space";

  const officeList = [
    { Name: "DBS", Rent: 50000, Address: "Chennai", img: imgDBS },
    { Name: "Regus", Rent: 75000, Address: "Bangalore", img: imgRegus },
    { Name: "WeWork", Rent: 60000, Address: "Mumbai", img: imgWeWork }
  ];

  return (
    <div>
      <h1>{element}, at Affordable Range</h1>

      {officeList.map((office, index) => {
        // Rent color logic
        let colors = [];
        if (office.Rent <= 60000) {
          colors.push("textRed");
        } else {
          colors.push("textGreen");
        }

        return (
          <div key={index}>
            <img src={office.img} width="25%" height="25%" alt={office.Name} />
            <h1>Name: {office.Name}</h1>
            <h3 className={colors.join(" ")}>Rent: Rs. {office.Rent}</h3>
            <h3>Address: {office.Address}</h3>
            <hr />
          </div>
        );
      })}
    </div>
  );
}

export default App;
