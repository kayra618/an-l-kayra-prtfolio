let mouseX = 0;
let mouseY = 0;
let dotX = 0;
let dotY = 0;
let outlineX = 0;
let outlineY = 0;

document.addEventListener('mousemove', (e) => {
    mouseX = e.clientX;
    mouseY = e.clientY;
    
    // Update background glow instantly (CSS variables are fine here)
    document.documentElement.style.setProperty('--mouse-x', e.clientX + 'px');
    document.documentElement.style.setProperty('--mouse-y', e.clientY + 'px');
});

function animate() {
    const dot = document.getElementById('cursor-dot');
    const outline = document.getElementById('cursor-outline');
    
    if (dot && outline) {
        // Dot follows fast (0.3 speed)
        dotX += (mouseX - dotX) * 0.3;
        dotY += (mouseY - dotY) * 0.3;
        
        // Outline follows slower (0.1 speed) - this creates the "outside" effect during fast moves
        outlineX += (mouseX - outlineX) * 0.12;
        outlineY += (mouseY - outlineY) * 0.12;
        
        dot.style.transform = `translate(-50%, -50%) translate(${dotX}px, ${dotY}px)`;
        outline.style.transform = `translate(-50%, -50%) translate(${outlineX}px, ${outlineY}px)`;
    }
    
    requestAnimationFrame(animate);
}

animate();

// Cursor hover effects
document.addEventListener('mouseover', (e) => {

    if (e.target.tagName === 'A' || e.target.tagName === 'BUTTON' || e.target.closest('.glass-card')) {
        document.getElementById('cursor-outline')?.classList.add('cursor-hover');
    }
});

document.addEventListener('mouseout', (e) => {
    if (e.target.tagName === 'A' || e.target.tagName === 'BUTTON' || e.target.closest('.glass-card')) {
        document.getElementById('cursor-outline')?.classList.remove('cursor-hover');
    }
});
