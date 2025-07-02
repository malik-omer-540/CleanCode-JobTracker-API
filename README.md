# JobTrackerAPI – Clean Code Demonstration

## 🎯 Goal

To demonstrate the **impact of clean code vs bad code** in a real-world .NET Core Web API scenario.

---

## 📌 Use Case: Job Application Tracker

A user submits a job application including:
- Company Name
- Position
- Status
- Applied Date
- Notes

---

## 🚫 Bad Code Endpoint: `POST /api/BadJobApplication`

### Problems:
- No validation
- No separation of concerns (logic is in controller)
- No meaningful method/variable names
- No DTOs
- No service layer

---

## ✅ Good Code Endpoint: `POST /api/GoodJobApplication`

### Improvements:
- **Single Responsibility Principle (SRP)**: Controller delegates to service.
- **DTO usage**: Clear contract between API and consumer.
- **Validation**: Ensures required data.
- **Meaningful naming**: Functions and variables clearly express intent.
- **Extensibility**: Easy to expand features (e.g., saving to DB, sending email).

---

## 🧠 Takeaway

> “Clean code always looks like it was written by someone who cares.”  
> – Robert C. Martin

Clean code is not a luxury. It reduces bugs, improves collaboration, and ensures long-term maintainability.

