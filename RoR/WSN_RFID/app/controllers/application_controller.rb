class ApplicationController < ActionController::Base
  # Prevent CSRF attacks by raising an exception.
  # For APIs, you may want to use :null_session instead.
  protect_from_forgery with: :exception

  before_filter :require_login

  helper_method :current_user

  helper_method :articulo_access?
  helper_method :alerta_access?
  helper_method :lector_access?
  helper_method :lectura_access?
  helper_method :permiso_access?
  helper_method :persona_access?
  helper_method :usuario_access?
  helper_method :vehiculo_access?


  protected
  def current_user
    @current_user ||= session.has_key?(:user_id) && Usuario.find(session[:user_id])
  end

  private
  def require_login
    redirect_to new_session_path unless current_user
  end

  def authorize_articulo
    unless articulo_access?
      flash[:notice] = "Acceso no autorizado"
      redirect_to root_path
      false
    end
  end

  def authorize_alerta
    unless alerta_access?
      flash[:notice] = "Acceso no autorizado"
      redirect_to root_path
      false
    end
  end

  def authorize_lector
    unless lector_access?
      flash[:notice] = "Acceso no autorizado"
      redirect_to root_path
      false
    end
  end
  def authorize_lectura
    unless lectura_access?
      flash[:notice] = "Acceso no autorizado"
      redirect_to root_path
      false
    end
  end
  def authorize_permiso
    unless permiso_access?
      flash[:notice] = "Acceso no autorizado"
      redirect_to root_path
      false
    end
  end
  def authorize_persona
    unless persona_access?
      flash[:notice] = "Acceso no autorizado"
      redirect_to root_path
      false
    end
  end
  def authorize_usuario
    unless usuario_access?
      flash[:notice] = "Acceso no autorizado"
      redirect_to root_path
      false
    end
  end
  def authorize_vehiculo
    unless vehiculo_access?
      flash[:notice] = "Acceso no autorizado"
      redirect_to root_path
      false
    end
  end

  ##Verificción de accesos

  def articulo_access?
    if current_user.permisos.first 
      return current_user.permisos.first.acceso_articulo
    else
      return false
    end
  end

  def alerta_access?
    if current_user.permisos.first 
      return current_user.permisos.first.acceso_alerta
    else
      return false
    end
  end

  def lector_access?
    if current_user.permisos.first 
      return current_user.permisos.first.acceso_lector
    else
      return false
    end
  end
  def lectura_access?
    if current_user.permisos.first 
      return current_user.permisos.first.acceso_lectura
    else
      return false
    end
  end
  def permiso_access?
    if current_user.permisos.first 
      return current_user.permisos.first.acceso_permiso
    else
      return false
    end
  end
  def persona_access?
    if current_user.permisos.first 
      return current_user.permisos.first.acceso_persona
    else
      return false
    end
  end
  def usuario_access?
    if current_user.permisos.first 
      return current_user.permisos.first.acceso_usuario
    else
      return false
    end
  end
  def vehiculo_access?
    if current_user.permisos.first 
      return current_user.permisos.first.acceso_vehiculo
    else
      return false
    end
  end
end
