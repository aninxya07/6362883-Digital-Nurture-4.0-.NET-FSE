import React from "react";
import imgDBS from "./images/dbs.jpg";
import imgRegus from "./images/regus.jpg";
import imgWeWork from "./images/wework.jpg";

function App() {
  // JSX heading element
  const heading = <h1 style={{ fontFamily: "Arial, sans-serif" }}>Office Space, at Affordable Range</h1>;

  // List of office objects
  const officeList = [
    { Name: "DBS", Rent: 50000, Address: "Chennai", img: imgDBS },
    { Name: "Regus", Rent: 75000, Address: "Bangalore", img: imgRegus },
    { Name: "WeWork", Rent: 60000, Address: "Mumbai", img: imgWeWork }
  ];

  return (
    <div style={{ padding: "20px" }}>
      {heading}

      {officeList.map((office, index) => (
        <div key={index} style={{ marginBottom: "30px" }}>
          <img
            src={office.img}
            alt={office.Name}
            width="25%"
            height="25%"
            style={{ marginBottom: "10px" }}
          />
          <h2>Name: {office.Name}</h2>
          <h3
            style={{
              color: office.Rent <= 60000 ? "red" : "green",
              fontWeight: "bold",
              fontSize: "20px"
            }}
          >
            Rent: Rs. {office.Rent}
          </h3>
          <h3>Address: {office.Address}</h3>
          <hr />
        </div>
      ))}
    </div>
  );
}

export default App;
