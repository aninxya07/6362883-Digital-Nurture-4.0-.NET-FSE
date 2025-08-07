import React from "react";

const CourseDetails = (props) => {
  // Conditional Rendering (&& operator)
  return (
    <div className="mystyle1">
      <h1>Course Details</h1>
      {props.courses.length > 0 &&
        props.courses.map((course) => (
          <div key={course.id}>
            <h2>{course.name}</h2>
            <h4>{course.date}</h4>
          </div>
        ))}
    </div>
  );
}

export default CourseDetails