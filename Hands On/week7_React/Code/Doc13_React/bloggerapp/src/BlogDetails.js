import React from "react";

export default function BlogDetails(props) {
  // Conditional Rendering (Ternary Operator)
  return (
    <div className="v1">
      <h1>Blog Details</h1>
      {props.blogs.length > 0 ? (
        props.blogs.map((blog) => (
          <div key={blog.id}>
            <h2>{blog.title}</h2>
            <h4>{blog.author}</h4>
            <p>{blog.content}</p>
          </div>
        ))
      ) : (
        <p>No blogs available.</p>
      )}
    </div>
  );
}
