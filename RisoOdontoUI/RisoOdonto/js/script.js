// Função para atualizar a classe ativa da barra de navegação com base na posição da página
function updateActiveSection() {
  // Seleciona todas as seções da página
  const sections = document.querySelectorAll('section'); 
  // Seleciona os links da barra de navegação
  const navLinks = document.querySelectorAll('.nav-link'); 

  sections.forEach((section, index) => {
    const sectionTop = section.offsetTop;
    const sectionHeight = section.clientHeight;
    const navLink = navLinks[index];

    if (window.scrollY >= sectionTop && window.scrollY < sectionTop + sectionHeight) {
      navLink.classList.add('active');
    } else {
      navLink.classList.remove('active');
    }
  });
}

// Evento de rolagem da página
window.addEventListener('scroll', updateActiveSection);

// Evento de carregamento da página
window.addEventListener('load', updateActiveSection);
