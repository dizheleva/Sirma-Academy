# Responsive Startup Website

A modern, responsive multi-page website template for startups, built with HTML, CSS, and JavaScript as part of a JavaScript workshop project. Features a clean design, mobile-first approach, and interactive navigation.

![Responsive Design](https://img.shields.io/badge/Responsive-Yes-green) ![HTML5](https://img.shields.io/badge/HTML5-E34F26?logo=html5&logoColor=white) ![CSS3](https://img.shields.io/badge/CSS3-1572B6?logo=css3&logoColor=white) ![JavaScript](https://img.shields.io/badge/JavaScript-F7DF1E?logo=javascript&logoColor=black)

---

## 📋 Table of Contents

- [About](#about)
- [Features](#features)
- [Pages](#pages)
- [Installation](#installation)
- [Usage](#usage)
- [Technologies Used](#technologies-used)
- [Project Structure](#project-structure)
- [Development](#development)
- [Contributing](#contributing)
- [License](#license)

---

## 🎯 About

This project is a responsive multi-page website created during a JavaScript workshop (Workshop 32-34). It demonstrates best practices in front-end web development, focusing on:

- Clean, semantic HTML structure
- Responsive design with mobile-first approach
- Modern CSS with custom properties and flexbox/grid layouts
- Interactive JavaScript functionality
- Cross-browser compatibility
- Accessibility considerations

The website serves as a complete template for startup companies, featuring a home page, portfolio showcase, services pricing, and contact form.

---

## ✨ Features

- **Fully Responsive Design** - Optimized for desktop, tablet, and mobile devices
- **Multi-page Navigation** - Home, Portfolio, Services, and Contact pages
- **Interactive Burger Menu** - Animated mobile navigation menu
- **Modern UI/UX** - Clean design with smooth transitions and hover effects
- **Team Section** - Showcase team members with cards
- **Portfolio Gallery** - Grid-based portfolio showcase
- **Services Pricing** - Service cards with pricing information
- **Contact Form** - Integrated contact form with Google Maps
- **Social Media Links** - Footer with social media icons
- **Custom CSS Variables** - Easy theming with CSS custom properties
- **Font Awesome Icons** - Professional iconography
- **Google Fonts** - Modern typography (Work Sans, Lato)

---

## 📄 Pages

- **Home (`index.html`)** - Landing page with hero section, partners, mission, solutions, and team
- **Portfolio (`portfolio.html`)** - Gallery showcasing work examples
- **Services (`services.html`)** - Service plans with pricing (Basic, Plus, Pro)
- **Contact (`contact.html`)** - Contact form with embedded Google Maps

---

## 🚀 Installation

### Prerequisites

- Node.js (v14 or higher recommended)
- npm or yarn package manager

### Setup

1. Clone the repository:
    ```bash
    git clone <repository-url>
    cd ResponsiveStartupWebsite
    ```

2. Install dependencies:
    ```bash
    npm install
    ```

3. Start the development server:
    ```bash
    npm run dev
    ```

4. Open your browser and navigate to the URL shown in the terminal (usually `http://localhost:5173`)

### Production Build

To create a production build:

```bash
npm run build
```

The built files will be in the `dist` folder.

---

## 💻 Usage

### Development Mode

Run the development server with hot-reload:

```bash
npm run dev
```

### Preview Production Build

Preview the production build locally:

```bash
npm run build
npm run preview
```

### Static Files

If you prefer to run without a build tool, you can open the HTML files directly in a browser, but note that:
- Some paths may need adjustment
- Vite-specific features won't work
- Recommended: Use the development server

---

## 🛠 Technologies Used

- **HTML5** - Semantic markup and structure
- **CSS3** - Modern styling with:
  - CSS Custom Properties (Variables)
  - Flexbox and Grid layouts
  - Media queries for responsiveness
  - Transitions and animations
- **JavaScript (ES6+)** - Vanilla JavaScript for:
  - Burger menu toggle functionality
  - DOM manipulation
  - Event handling
- **Vite** - Fast build tool and development server
- **Font Awesome 6** - Icon library
- **Google Fonts** - Web fonts (Work Sans, Lato)

---

## 📁 Project Structure

```
ResponsiveStartupWebsite/
├── index.html              # Home page
├── portfolio.html          # Portfolio page
├── services.html           # Services page
├── contact.html            # Contact page
├── package.json            # Project dependencies and scripts
├── vite.config.js         # Vite configuration
├── README.md              # Project documentation
│
├── public/                 # Static assets
│   ├── assets/
│   │   └── images/        # All images (logos, team photos, portfolio, etc.)
│   └── favicon/           # Favicon files
│
└── src/                    # Source files
    ├── js/
    │   └── script.js      # Main JavaScript file (burger menu functionality)
    ├── styles/
    │   ├── main.css       # CSS variables and base styles
    │   └── style.css      # Component styles and responsive design
    └── components/        # (Future component files)
```

### Key Files

- **`src/js/script.js`** - Handles burger menu toggle and navigation interactions
- **`src/styles/main.css`** - CSS custom properties, base styles, and typography
- **`src/styles/style.css`** - Component styles, layouts, and media queries
- **`public/assets/images/`** - All image assets (hero, team, portfolio, partners, etc.)

---

## 🔧 Development

### Scripts

- `npm run dev` - Start development server with hot-reload
- `npm run build` - Build for production
- `npm run preview` - Preview production build locally

### Responsive Breakpoints

The website uses the following breakpoints:
- **Desktop**: > 1280px
- **Tablet**: 768px - 1280px
- **Mobile**: < 768px
- **Small Mobile**: < 500px

### Customization

#### Colors

Edit CSS variables in `src/styles/main.css`:

```css
:root {
    --primary-color: rgb(116, 198, 157);
    --secondary-color: rgb(255, 255, 255);
    --tertiary-color: rgb(33, 37, 41);
    /* ... */
}
```

#### Content

- Update text content directly in HTML files
- Replace images in `public/assets/images/`
- Modify navigation links in all HTML files

---

## 🤝 Contributing

Contributions are welcome! If you find a bug or want to suggest an improvement:

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

---

## 📝 License

This project is created for educational purposes as part of a JavaScript Workshop (Workshop 32-34). 

If you wish to use this template for commercial projects, please review and add a suitable license.

---

## 👤 Author

Created as part of JavaScript Workshop 32-34

---

## 🙏 Acknowledgments

- Font Awesome for icons
- Google Fonts for typography
- Vite team for the excellent build tool
