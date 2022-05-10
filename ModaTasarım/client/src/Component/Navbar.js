import React from 'react'

function Navbar() {
    return (
        <div>


            <nav className="navbar navbar-expand-lg navbar-light fixed-top mask-custom shadow-0">
                <div className="container">
                    <a className="navbar-brand" href="#!"><span style={{ color: '#5e9693' }}>Hüsna</span><span style={{ color: '#fff' }}>Moda</span></a>
                    <button className="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                        <i className="fas fa-bars" />
                    </button>

                    <div className="collapse navbar-collapse" id="navbarSupportedContent">
                        <ul className="navbar-nav me-auto">
                            <li className="nav-item">
                                <a className="nav-link" href="#!">Anasayfa</a>
                            </li>
                            <li className="nav-item">
                                <a className="nav-link" href="#!">Hakkımızda</a>
                            </li>
                            <li className="nav-item">
                                <a className="nav-link" href="#!">Hizmetlerimiz</a>
                            </li>
                            <li className="nav-item">
                                <a className="nav-link" href="#!">İletişim</a>
                            </li>
                            <li className="nav-item">
                                <a className="nav-link" href="#!">Blog</a>
                            </li>
                            <li className="nav-item">
                                <a className="nav-link" href="#!">Team</a>
                            </li>
                            <li className="nav-item">
                                <a className="nav-link" href="#!">Contact</a>
                            </li>
                        </ul>
                        <ul className="navbar-nav d-flex flex-row">
                            <li className="nav-item me-3 me-lg-0">
                                <a className="nav-link" href="#!">
                                    <i className="fas fa-shopping-cart" />
                                </a>
                            </li>
                            <li className="nav-item me-3 me-lg-0">
                                <a className="nav-link" href="#!">
                                    <i className="fab fa-twitter" />
                                </a>
                            </li>
                            <li className="nav-item me-3 me-lg-0">
                                <a className="nav-link" href="#!">
                                    <i className="fab fa-instagram" />
                                </a>
                            </li>
                        </ul>
                    </div>
                </div>
            </nav>
        </div>
    )
}

export default Navbar