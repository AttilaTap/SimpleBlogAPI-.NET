# Simple Blog API

Hi 👋 this is a little project I made to learn .NET Web API. It just lets you make blog posts (title + content) and see them, update them, and delete too.

## How to use it

You need Visual Studio or something like that. I used .NET 7.

### Steps:

1. Clone this
2. Open in IDE (I used VS Code)
3. Run it (should open swagger page)

Swagger will help you test it, no need for frontend or Postman.

## Endpoints

- GET /api/posts => all posts
- GET /api/posts/{id} => one post
- POST /api/posts => create post
- PUT /api/posts/{id} => update post
- DELETE /api/posts/{id} => delete post

## Notes

Data doesn't save because it's in-memory DB. When you restart it's empty again. That’s fine for now lol.

---

Let me know if you have tips or stuff to improve! I’m learning 🙃