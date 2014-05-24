class ApplicationController < ActionController::Base
  # Prevent CSRF attacks by raising an exception.
  # For APIs, you may want to use :null_session instead.
  protect_from_forgery with: :exception

  before_filter :require_login

  helper_method :current_user

  protected
  def current_user
    @current_user ||= session.has_key?(:user_id) && Usuario.find(session[:user_id])
  end

  private
  def require_login
    redirect_to new_session_path unless current_user
  end
end
