# Heuristic Search

A Windows app that assigns tasks to processors. Two search services run locally. The client sends them a configuration file and shows the schedules they return.

---

## Overview

- Two search services, `AlgorithmServerOne` and `AlgorithmServerTwo`.
- A form that downloads a CFF configuration and calls both services.
- Results show runtime and energy for each schedule.

---

## Tech Stack

| Component | Technology |
| --- | --- |
| **Language** | C# |
| **UI** | Windows Forms, .NET Framework 4.7.2 |
| **Services** | WCF |
| **Search** | GeneticSharp 2.6.0 |

---

## Project Structure

```
HeuristicSearch/
├── FileFormat.sln
├── AlgorithmServerOne/
├── AlgorithmServerTwo/
├── ClientGUI/
├── FileFormat/
└── CommonInterfaces/
```

---

## Prerequisites

- Visual Studio with the .NET desktop workload (.NET Framework 4.7.2)

---

## Setup

Open `FileFormat.sln`, restore the NuGet packages, and build the solution.

---

## Run

Start `AlgorithmServerOne`, then `AlgorithmServerTwo`, then `ClientGUI`.

In the form, paste the full URL of a CFF file, enter a timeout in minutes, and run. Type `exit` in a server window to stop that server.
