let currentIndex = 0;

function nextSlide() {
  const slides = document.querySelectorAll('.slide');
  const slideWidth = slides[0].clientWidth;
  currentIndex = (currentIndex + 1) % slides.length;
  document.querySelector('.slider').style.transform = `translateX(-${slideWidth * currentIndex}px)`;
}

function prevSlide() {
  const slides = document.querySelectorAll('.slide');
  const slideWidth = slides[0].clientWidth;
  currentIndex = (currentIndex - 1 + slides.length) % slides.length;
  document.querySelector('.slider').style.transform = `translateX(-${slideWidth * currentIndex}px)`;
}

