import React from "react";
import "./App.css";
import BookDetails from "./BookDetails";
import BlogDetails from "./BlogDetails";
import CourseDetails from "./CourseDetails";

export default function App() {
  const books = [
    { id: 1, bname: "Master React", price: 670 },
    { id: 2, bname: "Deep Dive into Angular 11", price: 800 },
    { id: 3, bname: "Mongo Essentials", price: 450 }
  ];

  const blogs = [
    {
      id: 1,
      title: "React Learning",
      author: "Stephen Biz",
      content: "Welcome to learning React!"
    },
    {
      id: 2,
      title: "Installation",
      author: "Schwezdneier",
      content: "You can install React from npm."
    }
  ];

  const courses = [
    { id: 1, name: "Angular", date: "4/5/2021" },
    { id: 2, name: "React", date: "6/3/2021" }
  ];

  return (
    <div style={{ display: "flex", justifyContent: "space-around" }}>
      <BookDetails books={books} />
      <BlogDetails blogs={blogs} />
      <CourseDetails courses={courses} />
    </div>
  );
}
