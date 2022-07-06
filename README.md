# Litly

## Description

Litly is an application that aims to make writing more fun across all skill levels, it enables users to create writing prompts called "Story Lines" which other writers can then "Fork" to write there own take on the story. Users can then decide to create stories in a round robbin fashion taking turns to develop the narrative or add only their own posts over time. Feedback can be given in the form of comments on both Story Lines, Threads, and Posts as well.

## Current implementation

Currently a PoC API is developed with the ability to Login and Register Users with salted and hashed passwords along with JWT.
Users are able to Create, Read, Update, and Delete Story Lines via API endpoints as well as fork Story Lines.

## Tech Stack

Currently the API is built using C# .NET 5.0 WebApi using EF Core and SQLite. The Front End will be built using React.js.
